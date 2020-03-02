import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    round:0,
    bank:0,
    team_one:0,
    team_two:0,
    voprosy:[
      {
        text:'Как отмечают праздники женщины?',
        otvet:[
          {
            nomer:'1',
            text:'Пьют',
            raiting:100,
            close:false
          },
          {
            nomer:'2',
            text:'Идут в кино',
            raiting:80,
            close:false
          },
          {
            nomer:'3',
            text:'Идут в гости',
            raiting:60,
            close:false
          },
          {
            nomer:'4',
            text:'Дома с семъей',
            raiting:40,
            close:false
          },
          {
            nomer:'5',
            text:'С подругами',
            raiting:20,
            close:false
          },
          {
            nomer:'6',
            text:'С любимым',
            raiting:10,
            close:false
          }
        ]
      }
    ]
  },
  mutations: {
    setOpenOtvet(state,data){
      state.voprosy[state.round].otvet[data-1].close = !state.voprosy[state.round].otvet[data-1].close
    },
    setComplete(state,data){
      state.voprosy[state.round].otvet[data-1].close = true
      state.bank += state.voprosy[state.round].otvet[data-1].raiting
    },
    setTeam(state,data){
      if(data==1){
        state.team_one += state.bank
      }else{
        state.team_two += state.bank
      }
      state.bank = 0
    }
  },
  actions: {
    actShow({commit},data){
      commit('setOpenOtvet',data)
    },
    actComplete({commit},data){
      commit('setComplete',data)
    },
    actDoTeam({commit},data){
      commit('setTeam',data)
    }
  },
  modules: {
  },
  getters:{
    GetVopros(state){
      return state.voprosy[state.round].text
    },
    GetOtvets(state){
      return state.voprosy[state.round].otvet
    },
    GetBank(state){
      return state.bank
    },
    GetTeam1(state){
      return state.team_one
    },
    GetTeam2(state){
      return state.team_two
    }
  }
})

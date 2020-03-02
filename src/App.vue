<template>
  <div id="app">
    <div class="header_game">СТО К ОДНОМУ</div>
    <div class="bank_game">{{bank}}</div>
    <div class="main_panel">
      <div class="sumteam" @click="DoTeam(1)">{{team1}}</div>
      <div><router-view/></div>
      <div class="sumteam" @click="DoTeam(2)">{{team2}}</div>
    </div>
    <div class="control">
      <div class="nums">1</div>
      <div class="nums">2</div>
      <div class="nums">3</div>
      <div class="nums">4</div>
    </div>
  </div>
</template>
<script>
export default {
  computed:{
    bank(){
      return this.$store.getters.GetBank
    },
    team1(){
      return this.$store.getters.GetTeam1
    },
    team2(){
      return this.$store.getters.GetTeam2
    }
  },
  methods:{
    DoTeam(num){
      this.$store.dispatch('actDoTeam',num)
    }
  }
}
</script>
<style>
*{
  margin:0px;
  padding: 0px;
  box-sizing: border-box;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  width: 100%;
  height: 100vh;
  background-color: #3d4e86;
  
}
.header_game{
  color: yellow;
  padding: 1rem 0rem;
  font-size: 2rem;
  text-align: center;
}
.bank_game{
  text-align: center;
  color: coral;
  font-size: 3rem;
}
.main_panel{
  display:flex;
  justify-content:center;
  align-items: flex-start;
}
.sumteam{
  margin: 0px 3rem;
  padding: 2rem;
  border: 2px solid rgb(88, 240, 18);
  font-size: 3rem;
  color: aqua;
}
.control{
  display: flex;
  justify-content: flex-start;

}
.nums{
  margin: 1rem 1rem;
  padding: 0rem 1rem;
  font-size: 1.5rem;
}

</style>

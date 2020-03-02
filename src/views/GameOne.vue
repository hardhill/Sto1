<template>
  <div class="game_one">
    <div class="game-vopros">{{vopros}}</div>
    <Otvety v-for="otvet in otvety" :key="otvet.nomer" :nomer="otvet.nomer" :otvet="otvet.text" :open="otvet.close"/>
  </div>
</template>

<script>
// @ is an alias to /src
import Otvety from '@/components/Otvety'

export default {
  name: 'GameOne',
  components: {
    Otvety
  },
  computed:{
    vopros(){
      return this.$store.getters.GetVopros
    },
    otvety(){
      return this.$store.getters.GetOtvets
    }
  }
}
</script>
<style scoped>
.game_one{
  
  border: 1px solid rgb(51, 180, 192);
  border-radius: 10px;
}
.game-vopros{
  text-align: center;
  padding: 1rem 0rem 0.6rem 0rem;
  font-size: 2rem;
  color:burlywood;
}
</style>
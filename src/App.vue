<template>
  <div id="app">
    <div class="header_game">СТО К ОДНОМУ</div>
    <router-view/>
  </div>
</template>

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
  display: flex;
  justify-content: center;
}
.header_game{
  color: yellow;
  margin: 2rem 1rem;
  font-size: 2rem;
}


</style>

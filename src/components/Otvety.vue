<template>
    <div class="panel">
        <div class="switch">
        <div class="panel-off" v-show="!open" @click="DoShow(nomer)">{{nomer}}</div>
        <div class="panel-on" v-show="open" @click="DoShow(nomer)">{{otvet}}</div>
        </div>
        <div class="btn-vopros" @click="DoComplete(nomer)" v-show="!open"></div>
    </div>
</template>

<script>

export default {
    props:[
        'nomer',
        'otvet',
        'open'
    ],
    methods:{
        DoShow(nomer){
            this.$store.dispatch('actShow',nomer)
        },
        DoComplete(nomer){
            this.$store.dispatch('actComplete',nomer)
        }
    }
}
</script>
<style scoped>
.panel{
    display: flex;
    align-items: center;
    padding-right: 1rem; 
}
.switch{
    display: block;
}
.panel-off{
    padding: 1rem 1.5rem;
    width: 36rem;
    text-align: center;
    color: azure;
    font-size: 2rem;
    border: 3px solid rgb(213, 224, 110);
    margin: 1rem;
    border-radius: 10px;
}
.panel-on{
    padding: 1rem 1.5rem;
    width: 36rem;
    text-align: center;
    color: rgb(3, 33, 41);
    background-color: beige;
    font-size: 2rem;
    border: 3px solid rgb(213, 224, 110);
    margin: 1rem;
    border-radius: 10px;
}
.btn-vopros{
    width: 20px;
    height: 20px;
    border: 2px solid rgb(5, 46, 5);
    background-color: rgb(11, 71, 8);
}
</style>
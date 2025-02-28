<template>
  <v-app>
    <Sidebar /> 
    <v-main>
      <Header /> <!-- Cabeçalho -->
      <v-container>
        <router-view /> <!-- O conteúdo da página será renderizado aqui -->
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
// Importando os componentes necessários diretamente no app.vue
import Sidebar from '~/components/Sidebar.vue';
import Header from '~/components/Header.vue';
</script>

<style scoped>
/* Estilos globais */
</style>

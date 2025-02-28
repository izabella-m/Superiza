<template>
    <v-navigation-drawer app>ddddddddddddd
      <v-list>
        <v-list-item>
          <v-list-item-content>
            <v-list-item-title>Menu</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
        <v-list-item to="/">
          <v-list-item-content>
            <v-list-item-title>Meu estoque</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
        <v-list-item to="/fornecedores">
          <v-list-item-content>
            <v-list-item-title>fornecedores</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
        <v-list-item to="/pedidos">
          <v-list-item-content>
            <v-list-item-title>Acompanhar pedidos</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>
  </template>
  
  <script setup>
  // Lógica da barra lateral (se necessário)
  </script>
  
  <style scoped>
  /* Estilos específicos para a barra lateral */
  </style>
  
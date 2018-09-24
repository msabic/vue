<template>
 <v-app><router-view></router-view></v-app>
</template>

<script>
export default {
  data () {
    return {
      sideNav: false,
      // drawer: true,
      items: [
        {title: 'Active notes', icon: 'style', link: '/'},
        {title: 'Test', icon: 'delete_sweep', link: '/test'}
      ]
    }
  }
}
</script>

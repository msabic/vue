<template>
  <v-app dark >
    <v-navigation-drawer v-model="sideNav" fix app>
      <v-list>
        <v-list-tile>
          <v-list-tile-action>
            <v-icon>gavel</v-icon>
          </v-list-tile-action>
          <v-list-tile-content>View Meetups</v-list-tile-content>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer>
    <v-toolbar dark class="dark">
      <v-toolbar-side-icon
        @click.stop="sideNav = !sideNav"
        class="hidden-sm-and-up "></v-toolbar-side-icon>
      <v-toolbar-title>DevMeetup</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-toolbar-items class="hidden-xs-only">
        <v-btn  flat href="/test">
          <v-icon left dark>navigate_next</v-icon>
          Login
        </v-btn>
        <v-btn  flat>
          <v-icon left dark>navigate_before</v-icon>
          Logout
        </v-btn>
      </v-toolbar-items>
    </v-toolbar>
    <main>
        <router-view></router-view>
    </main>
      <v-footer
      dark
      height="auto"
      fix app
    >
      <v-card
        class="flex"
        flat
        tile
      >
        <v-card-title class="primary">
          <strong class="subheading">Get connected with us on social networks!</strong>
          <v-spacer></v-spacer>
          <v-btn
            v-for="icon in icons"
            :key="icon"
            class="mx-3"
            dark
            icon
          >
            <v-icon size="24px">{{ icon }}</v-icon>
          </v-btn>
        </v-card-title>
        <v-card-actions class="grey darken-3 justify-center">
          &copy;2018 — <strong>Mijo Šabić</strong>
        </v-card-actions>
      </v-card>
    </v-footer>
  </v-app>
</template>

<script>
export default {
  data () {
    return {
      sideNav: false,
      items: [
        {title: 'Test', icon: 'delete_sweep', link: '/test'}
      ],
      icons: [
        'face',
        'zoom_in',
        'zoom_out',
        'chat',
        'alarm'
      ]
    }
  }
}

</script>

<style lang="stylus"> @import './stylus/main'
</style>

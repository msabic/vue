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
        <v-btn  flat href="/#/test">
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

<style lang="stylus"> @import './stylus/main' </style>

<!--<template>
 <v-card
    color="grey lighten-4"
    flat
    height="200px"
  >
  <v-navigation-drawer v-model="sideNav"  fixed app>
      <v-list>
        <v-list-tile>
          <v-list-tile-action>
            <v-icon>gavel</v-icon>
          </v-list-tile-action>
          <v-list-tile-content>View Meetups</v-list-tile-content>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer>
    <v-toolbar color="grey darken-1" dark>
      <v-toolbar-side-icon  @click.stop="sideNav = !sideNav"
        class="hidden-sm-and-up "></v-toolbar-side-icon>

      <v-menu :nudge-width="100">
        <v-toolbar-title slot="activator">
          <span>All</span>
          <v-icon dark>arrow_drop_down</v-icon>
        </v-toolbar-title>

        <v-list>
          <v-list-tile
            v-for="item in items"
            :key="item"
             @click="foo">
            <v-list-tile-title v-text="item"></v-list-tile-title>
          </v-list-tile>
        </v-list>
      </v-menu>

      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>search</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>favorite</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>more_vert</v-icon>
      </v-btn>
    </v-toolbar>
  </v-card>
</template>

<script>
export default {
  data: () => ({
    sideNav: false,
    items: [
      'All', 'Family', 'Friends', 'Coworkers'
    ]
  })
}
</script>

<style lang="stylus">
  @import './stylus/main'
</style>-->

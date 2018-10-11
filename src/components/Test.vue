<template>
<v-app class="grey darken-1">
    <v-container fix app>
    <v-layout row ma-5 pa-5 >
      <v-flex xs12 sm6 offset-sm3 >
        <v-card >
          <v-card-text >
            <v-container >
              <form @submit.prevent="onSignup">
                <v-layout row >
                  <v-flex xs12>
                    <v-text-field
                      name="email"
                      label="Email"
                      id="email"
                      v-model="email"
                      type="email"
                      required></v-text-field>
                  </v-flex>
                </v-layout>
                <v-layout row>
                  <v-flex xs12>
                    <v-text-field
                      name="password"
                      label="Password"
                      id="password"
                      v-model="password"
                      type="password"
                      required></v-text-field>
                  </v-flex>
                </v-layout>
                <v-layout row>
                  <v-flex xs12>
                    <v-btn type="submit" @click="submit" href="/user">Sing in</v-btn>
                  </v-flex>
                </v-layout>
              </form>
            </v-container>
          </v-card-text>
        </v-card>
      </v-flex>
    </v-layout>
  </v-container>
</v-app>
</template>

<script>

</script>

 <style>

</style>

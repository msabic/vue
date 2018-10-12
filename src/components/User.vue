<template>
    <v-app class="blue lighten-5">
        <v-card-title >
            <v-flex xs18 sm6>
        </v-flex>
            <v-spacer></v-spacer>
        <v-btn light icon @click="add">
            <v-icon size="34px" >add</v-icon>
        </v-btn>
        <v-btn light icon >
            <v-icon size="34px" @click="mounted">edit</v-icon>
        </v-btn>
        <v-btn light icon >
            <v-icon size="34px" @click="mounted">delete</v-icon>
        </v-btn>
        </v-card-title >
        <v-card-title>
            <v-flex xs12 sm2>
          <v-text-field
          light
            ref="name"
            v-model="name"
            class="mx-3"
            label="Name"
            prepend-icon="person"
            single-line
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
          light
          ref="surname"
          v-model="surname"
            class="mx-3"
            label="Surname"
            prepend-icon="person"
            single-line
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
          light
          ref="email"
          v-model="email"
            class="mx-3"
            label="Email"
            single-line
            prepend-icon="email"
            type="email"
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
          light
          ref="contact"
          v-model="contact"
            class="mx-3"
            label="Contact"
            single-line
            prepend-icon="phone"
            type="phone"
          ></v-text-field>
        </v-flex>
         <v-switch
         light
         ref="active"
         v-model="active"
         class="mx-3"
            label="Active"
            prepend-icon="check"
            primary
            hide-details
          ></v-switch>
        </v-card-title>
        <v-data-table
    v-model="selected"
    :headers="headers"
    :items="user"
    :pagination.sync="pagination"
    select-all
    item-key="ID"
    class="elevation-1"
  >
    <template slot="headers" slot-scope="props">
      <tr light>
        <th>
          <v-checkbox
            :input-value="props.all"
            :indeterminate="props.indeterminate"
            primary
            hide-details
            @click.native="toggleAll"
          ></v-checkbox>
        </th>
        <th
          v-for="header in props.headers"
          :key="header.text"
          :class="['column sortable', pagination.descending ? 'desc' : 'asc', header.value === pagination.sortBy ? 'active' : '']"
          @click="changeSort(header.value)"
        >
          <v-icon small>arrow_upward</v-icon>
          {{ header.text }}
        </th>
      </tr>
    </template>
    <template slot="items" slot-scope="props">
      <tr :active="props.selected" @click="props.selected = !props.selected" class="grey darken-1">
        <td>
          <v-checkbox
            :input-value="props.selected"
            primary
            hide-details
          ></v-checkbox>
        </td>
        <td light style="display:none;" class="text-xs-center">{{ props.item.ID }}</td>
        <td light class="text-xs-center">{{ props.item.Name }}</td>
        <td light class="text-xs-center">{{ props.item.Surname }}</td>
        <td light class="text-xs-center">{{ props.item.Email }}</td>
        <td light class="text-xs-center">{{ props.item.Contact }}</td>
        <td light class="text-xs-reight"><v-checkbox primary hide-details :input-value=props.item.Active disabled>></v-checkbox></td>
        <td light class="text-xs-center">{{ props.item.Doctor }}</td>
      </tr>
    </template>
  </v-data-table>
    </v-app>
</template>

<script>
import axios from 'axios'
export default {
  data: () => ({
    sideNav: false,
    user: [],
    ID: null,
    Name: null,
    Surname: null,
    Email: null,
    Password: null,
    Contact: null,
    Location: null,
    Doctor: null,
    icons: [
      'add',
      'edit',
      'delete'
    ],
    pagination: {
      sortBy: 'name'
    },
    selected: [],
    headers: [
      { text: 'Name', align: 'center', value: 'Name' },
      { text: 'Surname', value: 'Surname' },
      { text: 'Email', value: 'Email' },
      { text: 'Contact', value: 'Contact' },
      { text: 'Active', value: 'Active' },
      { text: 'Doctor', value: 'Doctor' }
    ]
  }),

  methods: {
    toggleAll () {
      if (this.selected.length) this.selected = []
      else this.selected = this.user.slice()
    },
    changeSort (column) {
      if (this.pagination.sortBy === column) {
        this.pagination.descending = !this.pagination.descending
      } else {
        this.pagination.sortBy = column
        this.pagination.descending = false
      }
    },
    mounted () {
      axios
        .get('http://localhost:16586/api/user')
        .then(response => {
          this.user = response.data
          console.log('podaci', response.data)
        })
    },
    add () {
      console.log(this.name)
      axios
        .post('http://localhost:16586/api/user', {
          ID: 1,
          Name: this.name,
          Surname: this.surname,
          Email: this.email,
          Password: '',
          Contact: this.contact,
          Location: ''
        })
        .then((response) => {
          this.user.push(response)
          console.log(response)
        })
    }
  },
  created: function () {
    this.mounted()
  }
}
</script>

<style>

</style>

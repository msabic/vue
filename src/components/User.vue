<template>
    <v-app dark>
        <v-card-title >
            <v-flex xs18 sm6>
        </v-flex>
            <v-spacer></v-spacer>
        <v-btn dark icon @click="this.add()">
            <v-icon size="34px" >add</v-icon>
        </v-btn>
        <v-btn dark icon >
            <v-icon size="34px" @click="mounted">edit</v-icon>
        </v-btn>
        <v-btn dark icon >
            <v-icon size="34px" @click="mounted">delete</v-icon>
        </v-btn>
        </v-card-title >
        <v-card-title>
            <v-flex xs12 sm2>
          <v-text-field
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
          ref="contact"
          v-model="contact"
            class="mx-3"
            label="Contact"
            single-line
            prepend-icon="phone"
            type="phone"
          ></v-text-field>
        </v-flex>
         <v-checkbox
         ref="active"
         v-model="active"
         class="mx-3"
            label="Active"
            prepend-icon="check"
            primary
            hide-details
          ></v-checkbox>
        </v-card-title>
        <v-data-table
    v-model="selected"
    :headers="headers"
    :items="user"
    :pagination.sync="pagination"
    select-all
    item-key="Name"
    class="elevation-1"
  >
    <template slot="headers" slot-scope="props">
      <tr>
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
      <tr :active="props.selected" @click="props.selected = !props.selected">
        <td>
          <v-checkbox
            :input-value="props.selected"
            primary
            hide-details
          ></v-checkbox>
        </td>
        <td class="text-xs-center">{{ props.item.Name }}</td>
        <td class="text-xs-center">{{ props.item.Surname }}</td>
        <td class="text-xs-center">{{ props.item.Email }}</td>
        <td class="text-xs-center">{{ props.item.Contact }}</td>
        <td class="text-xs-reight"><v-checkbox primary hide-details :input-value=props.item.Active>></v-checkbox></td>
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
    name: null,
    username: null,
    email: null,
    contact: null,
    active: null,
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
      {
        text: 'Name',
        align: 'center',
        value: 'Name'
      },
      { text: 'Surname', value: 'Surname' },
      { text: 'Email', value: 'Email' },
      { text: 'Contact', value: 'Contact' },
      { text: 'Active', value: 'Active' }
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
    }
  },
  add () {
    console.log(this.name)
    return {
      name: this.name,
      username: this.username,
      email: this.email,
      contact: this.contact,
      active: this.active
    }
  },
  created: function () {
    this.mounted()
  }
}
</script>

<style>

</style>

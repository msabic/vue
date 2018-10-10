<template>
    <v-app dark>
        <v-card-title >
            <v-flex xs18 sm6>
        </v-flex>
            <v-spacer></v-spacer>
        <v-btn  v-for="icon in icons" :key="icon" dark icon >
            <v-icon size="34px" @click="mounted">{{ icon }}</v-icon>
        </v-btn>
        </v-card-title >
        <v-card-title>
            <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Dessert"
            single-line
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Calories"
            single-line
            type="number"
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Fat"
            single-line
            type="number"
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Carbs"
            single-line
            type="number"
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Protein"
            single-line
            type="number"
          ></v-text-field>
        </v-flex>
        <v-flex xs12 sm2>
          <v-text-field
            class="mx-3"
            label="Iron"
            single-line
            type="number"
          ></v-text-field>
        </v-flex>
        </v-card-title>
        <v-data-table
    v-model="selected"
    :headers="headers"
    :items="user"
    :pagination.sync="pagination"
    select-all
    item-key="name"
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
        <td>{{ props.item.name }}</td>
        <td class="text-xs-right">{{ props.item.calories }}</td>
        <td class="text-xs-right">{{ props.item.fat }}</td>
        <td class="text-xs-right">{{ props.item.carbs }}</td>
        <td class="text-xs-right">{{ props.item.protein }}</td>
        <td class="text-xs-right">{{ props.item.iron }}</td>
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
        text: 'Dessert (100g serving)',
        align: 'center',
        value: 'name'
      },
      { text: 'Calories', value: 'calories' },
      { text: 'Fat (g)', value: 'fat' },
      { text: 'Carbs (g)', value: 'carbs' },
      { text: 'Protein (g)', value: 'protein' },
      { text: 'Iron (%)', value: 'iron' }
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
        .get('http://localhost:16586/api/app/6')
        .then(response => {
          this.user = response.data
          console.log('podaci', response.data)
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

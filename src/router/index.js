import Vue from 'vue'
import Router from 'vue-router'
import Test from '@/components/Test'
import User from '@/components/User'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/test',
      name: 'Test',
      component: Test
    },
    {
      path: '/user',
      name: 'User',
      component: User
    }
  ]
})

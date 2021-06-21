//import http from '../http-common'
import axios from 'axios'

const baseUrl = `http://localhost:25094/api`

const getCar = (id) => {
  return axios.get(`${baseUrl}/Cars/${id}`)
}

const createRent = (data) => {
  return axios.post(`${baseUrl}/api/Rents`, data)
}

const DataService = {
  getCar,
  createRent,
  //getRent,
  //postData,
}

export default DataService

//import http from '../http-common'
import axios from 'axios'

const baseUrl = `http://localhost:25094/api`

async function getCarById(id) {
  try {
    const res = await axios.get(`${baseUrl}/Cars/${id}`)
    //console.log(res.data)
    return await Promise.resolve(res.data)
  } catch (err) {
    return Promise.reject(err)
  }
}

const getCar = (id) => {
  return axios.get(`${baseUrl}/Cars/${id}`)
}

/*
const getCarById = (id) => async () => {
  try {
    const res = await axios.get(`${baseUrl}/Cars/${id}`)
    //console.log(res.data)
    return Promise.resolve(res.data)
  } catch (err) {
    return Promise.reject(err)
  }
}
*/

const createRent = (data) => {
  return axios.post(`${baseUrl}/api/Rents`, data)
}

const DataService = {
  getCar,
  getCarById,
  createRent,
  //getRent,
  //postData,
}

export default DataService

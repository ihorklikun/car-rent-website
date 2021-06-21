import DataService from '../services/DataService'
import 

export const postRent = (data) => async () => {
  try {
    const res = await DataService.createRent({ data })

    return Promise.resolve(res.data)
  } catch (err) {
    return Promise.reject(err)
  }
}

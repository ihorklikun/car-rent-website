import http from '../http-common';

const getCarsList = async ()=>{
    return http.get("");
}

export default {
    getCarsList,
}
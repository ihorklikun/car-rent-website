import axios from 'axios';

export default axios.create({
    baseURL: "http://localhost:25094/api",
    headers: {
        "Content-type": "application/json",
        "accept": "application/json'"
    }
});
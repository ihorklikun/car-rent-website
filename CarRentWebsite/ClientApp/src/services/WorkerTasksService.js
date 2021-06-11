import http from "../http-common";

const getAllRequests = async ()=>{
    return await http.get(""); //get requests
}
const getAllActiveTasks = async() => {
    return await http.get(""); //get active tasks
}

export default {
    getAllRequests,
    getAllActiveTasks
}
//  other must be written here
import React, {useState, useEffect} from 'react';
import RequestTemplate from '../components/RequestTemplate';
import InProgressTemplate from '../components/InProgressTemplate';
import '../components/TemplateStyle.css';
import { Container, Col, Row } from 'react-bootstrap';
import WorkerTasksService from '../services/WorkerTasksService';
function ServiceTasksPage(){

    const [requestsData, saveData] = useState({
        isLoading: true,
        requests: null,
        inProgress: null
    });
    //const [inProgresstasksData, saveinProgressData] = useState(null)
    useEffect(()=>{
        saveData({isLoading: true});
        WorkerTasksService.getAllRequests().then((reply)=>{
            const receivedData = reply.data;
            saveData({isLoading: false, requests: receivedData, inProgress: receivedData});
        });
        WorkerTasksService.getAllActiveTasks().then((reply)=>{
            const receivedData = reply.data;
            saveData({isLoading: false, inProgress: receivedData});
        }).catch(e =>{
            saveData({isLoading: false});
            console.log(e);
        });
    }, [saveData]);
    if(requestsData.isLoading === true)
    return (<Container className = "text-center">
        <h2> Data is Loading</h2>
    </Container>);
    // else
    //     if(requestsData.data == null){
    //         return (<Container className = "text-center style">
    //             <h1>REQUESTS</h1>
    //             <h2>No data avaliable</h2>
    //             <h1>IN PROGRESS</h1>
    //         </Container>)
    //     }
    else return (<Container fluid>
        <Row className = "text-center style">
        <Col sm={0} md={1} lg = {2}></Col>
        <Col sm={12} md = {10} lg={8}>
        {/* <Col> */}
            <h1>REQUESTS</h1>
            <RequestTemplate/>
            <RequestTemplate/>
        {/* {data.requests.map((unit) => (<RequestTemplate data = {unit} />))} */}
        <h1>IN PROGRESS</h1>
        {/* {data.inProgress.map((unit) => (<RequestTemplate data = {unit} />))} */}
        <InProgressTemplate/>
        </Col>
        
    </Row>
    </Container>
    );
}
export default ServiceTasksPage;
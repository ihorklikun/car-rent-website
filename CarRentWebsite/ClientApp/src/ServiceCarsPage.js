import React, { useState, useEffect } from 'react'
import RequestTemplate from './RequestTemplate'
import InProgressTemplate from './InProgressTemplate'
import './TemplateStyle.css'
//import 'bootstrap/dist/css/bootstrap.min.css'
import { Container, Col, Row } from 'react-bootstrap'
import axios from 'axios'
function ServiceCarsPage() {
  const [data, saveData] = useState({
    isLoading: false,
    requests: null,
    inProgress: null,
  })
  // useEffect(()=>{
  //     saveData({isLoading: true});
  //     const apiUrl = 'https://www.smashingmagazine.com/2020/06/rest-api-react-fetch-axios/';
  //     axios.get(apiUrl).then((reply)=>{
  //         const receivedData = reply.data;
  //         saveData({isLoading: false, requests: receivedData, inProgress: receivedData});
  //     });
  // }, [saveData]);
  if (data.isLoading === true)
    return (
      <Container className='text-center'>
        <h2> Data is Loading</h2>
      </Container>
    )
  else
    return (
      <Row className='text-center style'>
        <Col sm={0} md={1} lg={2}></Col>
        <Col sm={12} md={10} lg={8}>
          {/* <Col> */}
          <h1>REQUESTS</h1>
          <RequestTemplate />
          <RequestTemplate />
          {/* {data.requests.map((unit) => (<RequestTemplate {...unit} />))} */}
          <h1>IN PROGRESS</h1>
          {/* {data.inProgress.map((unit) => (<RequestTemplate {...unit} />))} */}
          <InProgressTemplate />
        </Col>
      </Row>
    )
}
export default ServiceCarsPage

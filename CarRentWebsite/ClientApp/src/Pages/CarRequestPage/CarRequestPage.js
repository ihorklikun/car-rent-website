import React, { useState, useEffect } from 'react'
import RequestTemplate from './components/RequestTemplate'
import InProgressTemplate from './components/InProgressTemplate'
import './TemplateStyle.css'
//import 'bootstrap/dist/css/bootstrap.min.css'
import { Container, Col, Row } from 'react-bootstrap'
import axios from 'axios'

function CarRequestPage() {
  const [data, saveData] = useState({
    isLoading: false,
    requests: null,
    inProgress: null,
  })
  const baseUrl = `http://localhost:25094/api`

  const [cars, setCars] = useState(null)

  useEffect(() => {
    axios
      .get(`${baseUrl}/Cars/`)
      .then((responce) => {
        var data = responce.data
        console.log(data)
        if (data != null) {
          setCars(data)
        }
      })
      .catch((e) => {
        setCars(null)
        //console.log(e)
      })
  }, [setCars])

  if (data.isLoading === true)
    return (
      <Container className='text-center'>
        <h2> Data is Loading</h2>
      </Container>
    )
  else
    return (
      <Container>
        <Row className='text-center style'>
          <Col sm={0} md={1} lg={2}></Col>
          <Col sm={12} md={10} lg={8}>
            {/* <Col> */}
            <h1>REQUESTS</h1>

            <Container>
              {cars?.map((car, index) => (
                <RequestTemplate car={car} />
              ))}
            </Container>

            {/* {data.requests.map((unit) => (<RequestTemplate {...unit} />))} */}
            <h1>IN PROGRESS</h1>

            <Container>
              {cars?.map((car, index) => (
                <InProgressTemplate car={car} />
              ))}
            </Container>
            {/* {data.inProgress.map((unit) => (<RequestTemplate {...unit} />))} */}
          </Col>
        </Row>
      </Container>
    )
}
export default CarRequestPage

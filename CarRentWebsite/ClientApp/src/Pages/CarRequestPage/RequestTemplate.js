import React, { useState } from 'react'
import './TemplateStyle.css'
import { AiFillCar } from 'react-icons/ai'
import Button from 'react-bootstrap/Button'
import { Row, Col } from 'react-bootstrap'

function RequestTemplate(params) {
  return (
    <Row className='text-center templateStyle'>
      <Col md className='style1'>
        <h3>Car name</h3>
        <AiFillCar size='100px' />
      </Col>
      <Col md className='style2'>
        <h5 className='headerText'>Car supply place</h5>
        <p className='dataText text-left'>Place will be here</p>
        <h5 className='headerText'>Place of return of the car</h5>
        <p className='dataText text-left'>place will be here</p>
        <h5 className='headerText'>User</h5>
        <Row>
          <Col md className='style2'>
            <p className='dataText text-left'>id:someuser@gmail.com</p>
          </Col>
          <Col md className='style2'>
            <Button variant='warning' className='buttonStyle'>
              Info
            </Button>
          </Col>
        </Row>
      </Col>
      <Col md className='style3'>
        <Row>
          <h5 className='headerText'>Additional options</h5>
          <p>GPS 5$/day</p>
        </Row>
        <Row className='fixed-row-to-bottom'>
          <h5 className='headerText'>Total price: </h5>
          <Button variant='success' className='buttonStyle'>
            Process
          </Button>
        </Row>
        
      </Col>
    </Row>
  )
}

export default RequestTemplate

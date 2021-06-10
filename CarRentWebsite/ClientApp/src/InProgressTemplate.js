import React, { useState } from 'react'
import { AiFillCar } from 'react-icons/ai'
import './TemplateStyle.css'
import Button from 'react-bootstrap/Button'
import { Row } from 'react-bootstrap'
import { Col } from 'react-bootstrap'
import { Form } from 'react-bootstrap'
import { Modal } from 'react-bootstrap'

function InProgressTemplate(params) {
  const [showModal1, setShow1] = useState(false)
  return (
    <Row fluid className='text-center templateStyle'>
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
          <Button
            variant='danger'
            className='buttonStyle'
            onClick={() => setShow1(true)}
          >
            Return car
          </Button>
          <ModalWindow show={showModal1} onHide={() => setShow1(false)} />
        </Row>
      </Col>
    </Row>
  )
}

export default InProgressTemplate

function ModalWindow(props) {
  const [isActive, setActive] = useState(true)
  const firstOption = () => {
    setActive(!isActive)
  }
  return (
    <Modal {...props} aria-labelledby='contained-modal-title-vcenter' centered>
      <Modal.Header closeButton>
        <Modal.Title>Options selection</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Col>
          <Button
            variant={isActive ? 'primary' : 'secondary'}
            className='ModalButtonStyle'
            onClick={firstOption}
            active={isActive}
          >
            Some option here
          </Button>
          <Button
            variant='secondary'
            className='ModalButtonStyle'
            onClick={props.onHide}
          >
            Some option here
          </Button>
        </Col>
      </Modal.Body>
      <Modal.Footer>
        <Button variant='warning' onClick={props.onHide}>
          Close
        </Button>
      </Modal.Footer>
    </Modal>
  )
}

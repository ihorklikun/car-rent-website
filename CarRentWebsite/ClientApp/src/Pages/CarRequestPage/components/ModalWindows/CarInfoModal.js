import React, { useState } from 'react'
import Button from 'react-bootstrap/Button'
import { Col, Row } from 'react-bootstrap'
import { Modal } from 'react-bootstrap'
import './ModalStyles.css'

export const CarInfoModal = (props) => {
  const [isActive, setActive] = useState(true)
  const firstOption = () => {
    setActive(!isActive)
  }
  return (
    <Modal {...props} aria-labelledby='contained-modal-title-vcenter' centered>
      <Modal.Header closeButton>
        <Modal.Title>Car Info</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Col>
          <Row>
            <h5 className='headerText'>Car model</h5>

            <h4 className='dataTextModal'>
              {props.car?.brand.name ?? 'brand'} {props.car?.model ?? 'model'}
            </h4>
          </Row>
          <Row>
            <h5 className='headerText'>Car Car Type</h5>

            <h4 className='dataTextModal'>{props.car?.carType.name}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>Car fiel</h5>

            <h4 className='dataTextModal'>{props.car?.fuel.name}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>Car driven kilomiters</h5>

            <h4 className='dataTextModal'>{props.car?.kilometersDriven}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>Car registerNumber</h5>

            <h4 className='dataTextModal'>{props.car?.registerNumber}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>Car registerDate</h5>

            <h4 className='dataTextModal'>{props.car?.registerDate}</h4>
          </Row>
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

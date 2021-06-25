import React, { useState } from 'react'
import Button from 'react-bootstrap/Button'
import { Col, Row } from 'react-bootstrap'
import { Modal } from 'react-bootstrap'
import './ModalStyles.css'

export const UserInfoModal = (props) => {
  const [isActive, setActive] = useState(true)
  const firstOption = () => {
    setActive(!isActive)
  }

  return (
    <Modal {...props} aria-labelledby='contained-modal-title-vcenter' centered>
      <Modal.Header closeButton>
        <Modal.Title>User Info</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Col>
          <Row>
            <h5 className='headerText'>Name</h5>

            <h4 className='dataTextModal'>{props.UserData?.name}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>SurName</h5>

            <h4 className='dataTextModal'>{props.UserData?.surname}</h4>
          </Row>
          <Row>
            <h5 className='headerText'>Email</h5>

            <h4 className='dataTextModal'>{props.UserData?.email}</h4>
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

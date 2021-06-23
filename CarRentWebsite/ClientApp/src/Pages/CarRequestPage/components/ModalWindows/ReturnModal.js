import React, { useState } from 'react'
import Button from 'react-bootstrap/Button'
import { Col } from 'react-bootstrap'
import { Modal } from 'react-bootstrap'

export const ReturnModal = (props) => {
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

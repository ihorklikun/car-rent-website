import React, { useState } from 'react'
import '../TemplateStyle.css'
import Button from 'react-bootstrap/Button'
import { Row } from 'react-bootstrap'
import { Col } from 'react-bootstrap'
import { Modal } from 'react-bootstrap'
import styled from 'styled-components'
import { ReturnModal } from './ModalWindows/ReturnModalWindow'
import { CarInfoModal } from './ModalWindows/CarInfoModal'

const ModalContent = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  line-height: 1.8;
  color: #141414;

  p {
    margin-bottom: 1rem;
  }

  button {
    padding: 10px 24px;
    background: #141414;
    color: #fff;
    border: none;
  }
`

function InProgressTemplate({ car }) {
  const [returnModal, setReturnModal] = useState(false)
  const [infoModal, setInfoModal] = useState(false)

  return (
    <Row fluid className='text-center templateStyle'>
      <Col md className='style1'>
        <h4 className='headerText'>
          {car?.brand.name ?? 'brand'} {car?.model ?? 'model'}
        </h4>
        <img
          className='ImageStyle'
          variant='top'
          src={car?.imageUrl ?? 'Car image'}
        />
        <Button
          variant='warning'
          className='buttonStyle'
          onClick={() => setInfoModal(true)}
        >
          CarInfo
        </Button>
      </Col>
      <Col md className='style2'>
        <h5 className='headerText'>Car supply place</h5>
        <p className='dataText text-left'>
          {car?.location.city.name ?? 'location'}
        </p>
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
            onClick={() => setReturnModal(true)}
          >
            Return car
          </Button>
          <ModalContent>
            <ReturnModal
              show={returnModal}
              onHide={() => setReturnModal(false)}
            />
          </ModalContent>
          <ModalContent>
            <CarInfoModal
              show={infoModal}
              onHide={() => setInfoModal(false)}
              car={car}
            />
          </ModalContent>
        </Row>
      </Col>
    </Row>
  )
}

export default InProgressTemplate

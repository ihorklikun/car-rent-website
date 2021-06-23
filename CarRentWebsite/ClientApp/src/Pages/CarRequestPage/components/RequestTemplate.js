import React, { useState, useEffect } from 'react'
import '../TemplateStyle.css'
import Button from 'react-bootstrap/Button'
import { Row, Col, Container } from 'react-bootstrap'
import { CarInfoModal } from './ModalWindows/CarInfoModal'
import { UserInfoModal } from './ModalWindows/UserInfoModal'
import { ReturnModal } from './ModalWindows/ReturnModal'

import styled from 'styled-components'
import axios from 'axios'

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

function RequestTemplate({ car }) {
  const [returnModal, setReturnModal] = useState(false)
  /*
   const [showModal, setShowModal] = useState(false)
 
  const openModal = () => {
    setShowModal((prev) => !prev)
  }
*/
  const [infoModal, setInfoModal] = useState(false)
  const [userInfoModal, setUserInfoModal] = useState(false)

  const [options, setOptions] = useState(null)

  const baseUrl = `http://localhost:25094/api`

  useEffect(() => {
    axios
      .get(`${baseUrl}/RentAdditionalOptions/`)
      .then((responce) => {
        var data = responce.data
        //console.log(data)
        if (data != null) {
          setOptions(data)
        }
      })
      .catch((e) => {
        setOptions(null)
        console.log(e)
      })
    //console.log(options)
  }, [setOptions])

  var personInfo = localStorage.getItem('person')
  var UserData = JSON.parse(personInfo)
  //console.log(UserData)

  return (
    <Container className='text-center templateStyle'>
      <Row>
        <Col md className='style1'>
          <h4 className='headerText'>
            {car?.brand.name ?? 'brand'} {car?.model ?? 'model'}
          </h4>
          <img
            className='ImageStyle'
            variant='top'
            src={car?.imageUrl ?? 'Car image'}
          />
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
              <p className='dataText text-left'>{UserData?.Email}</p>
            </Col>
          </Row>
        </Col>
        <Col md className='style3'>
          <Row>
            <h5 className='headerText'>Additional options</h5>
            <Container>
              {options?.map((option, index) => (
                <div>
                  <label className='dataText text-left'>
                    <p4 value={option.id} />
                    {option.name}
                  </label>
                </div>
              ))}
            </Container>
          </Row>
          <Row className='fixed-row-to-bottom'>
            <h5 className='headerText'>Total price: 400</h5>

            <ModalContent>
              <CarInfoModal
                show={infoModal}
                onHide={() => setInfoModal(false)}
                car={car}
              />
            </ModalContent>
            <ModalContent>
              <ReturnModal
                show={returnModal}
                onHide={() => setReturnModal(false)}
              />
            </ModalContent>
            <ModalContent>
              <UserInfoModal
                show={userInfoModal}
                onHide={() => setUserInfoModal(false)}
                UserData={UserData}
              />
            </ModalContent>
          </Row>
        </Col>
      </Row>
      <Row>
        <Col>
          <Button
            variant='warning'
            className='buttonStyle'
            onClick={() => setInfoModal(true)}
          >
            CarInfo
          </Button>
        </Col>
        <Col md className='style2'>
          <Button
            variant='warning'
            className='buttonStyle'
            onClick={() => setUserInfoModal(true)}
          >
            User Info
          </Button>
        </Col>
        <Col>
          <Button
            variant='success'
            className='buttonStyle'
            onClick={() => setReturnModal(true)}
          >
            Process
          </Button>
        </Col>
      </Row>
    </Container>
  )
}

export default RequestTemplate

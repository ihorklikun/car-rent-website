import ReactStars from 'react-rating-stars-component'
import React, { useState, useEffect, useFriendStatus } from 'react'
import './TemplateStyle.css'
import { Container, Col, Row, Form } from 'react-bootstrap'
import { AiFillCar } from 'react-icons/ai'
import Button from 'react-bootstrap/Button'

let carList = [
  { id: 1, name: 'Renault megane' },
  { id: 2, name: 'Audi a7' },
]

let adressList = [
  { id: 1, name: 'Lviv' },
  { id: 2, name: 'Kyiv' },
]

function BookingCarPage() {
  const [data, saveData] = useState({
    isLoading: false,
    requests: null,
    inProgress: null,
  })

  const [carId, setCarId] = useState(1)
  const [price, setPrice] = useState(100)
  const [starsCount, setStarsCount] = useState(5)
  const [startAdressId, setStartAdress] = useState(1)
  const [endAdressId, setEndAdress] = useState(1)

  //rename
  const RecalculatePrice = () => {
    console.log(price)
    //alert(newRating)
    setPrice(price - 5)
    alert(-5)
  }

  //useEffect(()=>{
  //    saveData({isLoading: true});
  //    const apiUrl = 'https://www.smashingmagazine.com/2020/06/rest-api-react-fetch-axios/';
  //    axios.get(apiUrl).then((reply)=>{
  //        const receivedData = reply.data;
  //        saveData({isLoading: false, requests: receivedData, inProgress: receivedData});
  //    });
  //}, [saveData]);

  if (data.isLoading === true)
    return (
      <Container>
        <h2> Data is Loading</h2>
      </Container>
    )
  else
    return (
      <Container>
        <h1>CAR BOOKING</h1>
        <Row>
          <Col sm={7}>
            <h5 className='headerText'>Choose a car</h5>
            <select
              className='dataText'
              name='cars'
              value={carId}
              onChange={(e) => setCarId(Number(e.target.value))}
            >
              {carList.map((car) => (
                <option key={car.id} value={car.id}>
                  {car.name}
                </option>
              ))}
            </select>
            <h5 className='headerText'>Car supply place</h5>
            <Row>
              <Col sm={5}>
                <select
                  className='dataText'
                  name='placeFrom'
                  value={startAdressId}
                  onChange={(e) => setStartAdress(Number(e.target.value))}
                >
                  {adressList.map((adress) => (
                    <option key={adress.id} value={adress.id}>
                      {adress.name}
                    </option>
                  ))}
                </select>
              </Col>
              <Col sm={4}>
                <input
                  className='dataText text-left'
                  type='date'
                  id='startDate'
                  name='startDate'
                  value='2020-07-22'
                  min='2020-01-01'
                  max='2100-12-31'
                />
              </Col>
              <Col sm={3}>
                <input
                  className='dataText text-left'
                  type='time'
                  id='startTime'
                  name='startTime'
                  min='09:00'
                  max='18:00'
                  required
                />
              </Col>
            </Row>
            <h5 className='headerText'>Place of return the car</h5>
            <Row>
              <Col sm={5}>
                <select
                  className='dataText'
                  name='placeTo'
                  value={endAdressId}
                  onChange={(e) => setEndAdress(Number(e.target.value))}
                >
                  {adressList.map((adress) => (
                    <option key={adress.id} value={adress.id}>
                      {adress.name}
                    </option>
                  ))}
                </select>
              </Col>
              <Col sm={4}>
                <input
                  className='dataText text-left'
                  type='date'
                  id='endDate'
                  name='endDate'
                  value='2020-07-22'
                  min='2020-01-01'
                  max='2100-12-31'
                />
              </Col>
              <Col sm={3}>
                <input
                  className='dataText text-left'
                  type='time'
                  id='endTime'
                  name='endTime'
                  min='09:00'
                  max='18:00'
                  required
                />
              </Col>
            </Row>
            <h5 className='headerText'>Additional options</h5>
            <Col>
              <Form.Check checked={true} label='some option' />
            </Col>
            <Col>
              <Form.Check checked={true} label='some option 2' />
            </Col>
          </Col>
          <Col>
            <Col className='templateStyle'>
              <h4>Car Name</h4>
              <AiFillCar size='200px' />

              <Row className='text-center'>
                <Col sm={7}>
                  <ReactStars
                    count={5}
                    value={starsCount}
                    size={24}
                    isHalf={true}
                    activeColor='#ffd700'
                  />
                </Col>
                <Col sm={1}>
                  <h4>{starsCount}</h4>
                </Col>
              </Row>
              <h5 className='headerText'>Total {price}$ </h5>
            </Col>
            <Col>
              <Row>
                <Col className='my-auto'>
                  <p1 className='dataText'>Promocode</p1>
                </Col>
                <Col>
                  <Button variant='warning' onClick={RecalculatePrice}>
                    Activate
                  </Button>
                </Col>
              </Row>
              <Row className='text-right'>
                <Button
                  className='BookingButton'
                  variant='warning'
                  onClick={GoToUserPage()}
                >
                  BOOK
                </Button>
              </Row>
            </Col>
          </Col>
        </Row>
      </Container>
    )
}

function GoToUserPage() {}

export default BookingCarPage

/*

<ReactStars
                  count={5}
                  onChange={(rating) => {
                    setStarsCount(rating)
                  }}
                  size={24}
                  isHalf={true}
                  emptyIcon={<i className='far fa-star'></i>}
                  halfIcon={<i className='fa  fa-star-half-alt'></i>}
                  fullIcon={<i className='fa fa-star'></i>}
                  activeColor='#ffd700'
                />
*/

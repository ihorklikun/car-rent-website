import ReactStars from 'react-rating-stars-component'
import React, { useState, useEffect, useFriendStatus, Suspense } from 'react'
import styled from 'styled-components'
import './TemplateStyle.css'
import { Container, Col, Row, Form } from 'react-bootstrap'
import { AiFillCar } from 'react-icons/ai'
import Button from 'react-bootstrap/Button'
import { useHistory, useLocation } from 'react-router-dom'
import DataService from './services/DataService'
import axios from 'axios'
//import CheckboxesComponent from './component/Checkboxes'

const ModalWrapper = styled.div`
  display: block;
  margin-left: auto;
  margin-right: auto;
  margin-top: 4%;
  margin-bottom: 4%;
  width: 75%;
  height: 90%;
  box-shadow: 0 5px 16px rgba(0, 0, 0, 0.2);
  background: #fff;
  color: #000;
  display: grid;
  position: relative;
  z-index: 10;
  border-radius: 10px;
`

function BookingCarPage() {
  const [data, saveData] = useState({
    isLoading: false,
    requests: null,
    inProgress: null,
  })
  let history = useHistory()

  var personInfo = localStorage.getItem('person')
  var UserData = JSON.parse(personInfo)
  //console.log(UserData)

  const initialRentState = {
    beginDate: '2021-06-19',
    endDate: '2021-06-19',
    beginTime: '19:51:00',
    endTime: '19:51:00',
    price: 100,
    pricePerDay: 1,
    promocode: 10,
    rentStatusId: 1,
    customerId: UserData.id,
    starsCount: 4,
    carId: document.URL.substring(document.URL.lastIndexOf('/') + 1),
    additionalOptions: [
      {
        id: 0,
      },
    ],
  }

  const [rent, setRent] = useState(initialRentState)

  const [carRes, setCarRes] = useState(DataService.getCarById(rent.carId))

  let price = rent?.price ?? 'price'
  //console.log(carRes)
  //-----------------------------------
  const baseUrl = `http://localhost:25094/api`

  const [car, setCar] = useState(null)

  useEffect(() => {
    axios
      .get(`${baseUrl}/Cars/${rent.carId}`)
      .then((responce) => {
        var data = responce.data
        //console.log(data.model)
        if (data != null) {
          setCar(data)
        }
      })
      .catch((e) => {
        setCar(null)
        //console.log(e)
      })
  }, [setCar])

  const [options, setOptions] = useState(null)

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

  const RecalculatePrice = () => {
    let start = new Date(rent.beginDate)
    console.log('first ' + start)

    let end = new Date(rent.endDate)
    console.log('second ' + end)

    let days = Math.floor(end / 8.64e7) - Math.floor(start / 8.64e7)

    console.log('days ' + days)

    //console.log(car)

    let prices = car?.carPrices
    //console.log(prices)

    let dayPrice = prices[0]

    prices.forEach((element) => {
      if (days > element.daysCount) {
        dayPrice = element
        return false
      }
    })

    rent.pricePerDay = dayPrice
    rent.pricePerDay.daysCount = days

    if (days <= 0) days = 1

    price = days * dayPrice.price
    if (isNaN(price)) {
      price = rent.pricePerDay
    }

    rent.price = days * dayPrice.price
    //alert(price)
    //price = rent.price
    console.log(rent)
  }

  const handleInputChange = (event) => {
    const { name, value } = event.target
    RecalculatePrice()
    setRent({ ...rent, [name]: value })
  }

  const saveRent = () => {
    const rentJson = {
      beginDate: rent.beginDate + 'T' + rent.beginTime + 'Z',
      endDate: rent.endDate + 'T' + rent.endTime + 'Z',
      price: rent.price,
      rentStatusId: 1,
      customerId: rent.customerId,
      carId: rent.carId,
      additionalOptions: rent.additionalOptions,
    }

    console.log(rentJson)

    /*axios
      .post(`${baseUrl}/Rents`, rentJson)
      .then((responce) => {
        var data = responce.data
        console.log(data)
      })
      .catch((e) => {
        console.log(e)
      })
      */
  }

  const newRent = () => {
    //setTutorial(initialTutorialState)
    //console.log(rent)
    saveRent()
    GoToUserPage()
  }

  const handleIdChange = (e) => {
    let tempValue = e.target.value
    if (!rent.additionalOptions.includes(tempValue)) {
      rent.additionalOptions.push(tempValue)
    } else {
      rent.additionalOptions.pop(tempValue)
    }
  }

  if (data.isLoading === true)
    return (
      <Container>
        <h2> Data is Loading</h2>
      </Container>
    )
  else
    return (
      <ModalWrapper>
        <h1 className='BookingHeader'>CAR BOOKING</h1>
        <Row>
          <Col>
            <h5 className='headerText'>Car supply date</h5>
            <Row>
              <Col>
                <input
                  className='dataText text-left'
                  type='date'
                  id='beginDate'
                  name='beginDate'
                  value={rent.beginDate}
                  min='2020-01-01'
                  max='2100-12-31'
                  onChange={handleInputChange}
                />
              </Col>
              <Col>
                <input
                  className='dataText text-left'
                  type='time'
                  id='beginTime'
                  value={rent.beginTime}
                  name='beginTime'
                  min='09:00'
                  max='18:00'
                  onChange={handleInputChange}
                />
              </Col>
            </Row>
            <h5 className='headerText'>Place of return the car</h5>
            <Row>
              <Col>
                <input
                  className='dataText text-left'
                  type='date'
                  id='endDate'
                  name='endDate'
                  value={rent.endDate}
                  min='2020-01-01'
                  max='2100-12-31'
                  onChange={handleInputChange}
                />
              </Col>
              <Col>
                <input
                  className='dataText text-left'
                  type='time'
                  id='endTime'
                  name='endTime'
                  value={rent.endTime}
                  min='09:00'
                  max='18:00'
                  onChange={handleInputChange}
                />
              </Col>
            </Row>
            <h5 className='headerText'>Additional options</h5>
            <Container className='CheckBoxStyle'>
              {options?.map((option, index) => (
                <div>
                  <label>
                    <input
                      type='checkbox'
                      id='id'
                      name='id'
                      value={option.id}
                      onChange={handleIdChange}
                    />
                    {option.name}
                  </label>
                </div>
              ))}
            </Container>
          </Col>
          <Col>
            <Col className='templateStyle'>
              <h4 className='headerText'>
                {car?.brand.name ?? 'brand'} {car?.model ?? 'model'}
              </h4>
              <img
                className='ImageStyle'
                variant='top'
                src={car?.imageUrl ?? 'Car image'}
              />
              <Row className='starsRow'>
                <Col>
                  <ReactStars
                    count={5}
                    value={rent.starsCount}
                    size={24}
                    isHalf={true}
                    activeColor='#ffd700'
                    onChange={handleInputChange}
                  />
                </Col>
                <Col>
                  <h4>{rent.starsCount}</h4>
                </Col>
              </Row>
              <h5 className='headerText'>Total {rent.price ?? 'price'}</h5>
            </Col>
            <Col>
              <Row>
                <Col>
                  <input
                    className='PromocodeInput'
                    type='text'
                    value={rent.promocode}
                    onChange={handleInputChange}
                  />
                </Col>
                <Col>
                  <Button variant='warning' onClick={RecalculatePrice}>
                    Activate
                  </Button>
                </Col>
              </Row>
            </Col>
          </Col>
        </Row>
        <Row>
          <Button className='BookingButton' variant='warning' onClick={newRent}>
            BOOK
          </Button>
        </Row>
      </ModalWrapper>
    )

  function GoToUserPage() {
    history.push({
      pathname: '/user/' + UserData.id, // userId must be here
      state: { personId: UserData.id }, // here too
    })
  }
}

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

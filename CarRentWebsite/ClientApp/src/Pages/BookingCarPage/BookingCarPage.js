import ReactStars from 'react-rating-stars-component'
import React, { useState, useEffect, useFriendStatus, Suspense } from 'react'
import styled from 'styled-components'
import './TemplateStyle.css'
import { Container, Col, Row, Form } from 'react-bootstrap'
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

  var personInfo = localStorage.getItem('currentUser')
  var UserData = JSON.parse(personInfo)
  //console.log(UserData)

  var today = new Date()
  var time =
    today.getHours() + ':' + today.getMinutes() + ':' + today.getSeconds()

  var today = new Date()
  var dd = String(today.getDate()).padStart(2, '0')
  var mm = String(today.getMonth() + 1).padStart(2, '0') //January is 0!
  var yyyy = today.getFullYear()
  today = mm + '/' + dd + '/' + yyyy
  //console.log(today)

  const initialRentState = {
    beginDate: today,
    endDate: today,
    beginTime: time,
    endTime: time,
    price: 100,
    pricePerDay: 100,
    daysCount: 1,
    rentStatusId: 1,
    customerId: UserData?.id,
    starsCount: 5,
    carId: document.URL.substring(document.URL.lastIndexOf('/') + 1),
    additionalOptions: [],
  }

  const [rent, setRent] = useState(initialRentState)

  //console.log(rent)

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
        //console.log(data)
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
    //alert('test')
    let start = new Date(rent.beginDate)
    console.log('first ' + start)

    let end = new Date(rent.endDate)
    console.log('second ' + end)

    let days = Math.floor(end / 8.64e7) - Math.floor(start / 8.64e7)

    //if (days == 0) days = 30

    console.log(rent)
    console.log('days ' + days)

    if (days < 0) {
      alert(
        'quantity of days must be more than 0!\n please set correct data and try one more time'
      )
      return
    }

    var prices = car?.carPrices ?? [{ daysCount: 1, price: 1 }]

    /*
    var prices = [
      { daysCount: 1, price: 70 },
      { daysCount: 4, price: 50 },
    ]
    */

    console.log(prices)
    let dayPrice

    if (prices[0].price == 1) {
      alert('Cant rean value about price per day from data base\n try later :)')
      dayPrice = 100
      return
    } else {
      dayPrice = prices[0]

      prices.forEach((element) => {
        if (days > element.daysCount) {
          dayPrice = element
          return false
        }
      })
    }

    rent.pricePerDay = dayPrice
    rent.daysCount = days

    if (days <= 0) days = 1

    rent.price = days * dayPrice.price

    if (isNaN(rent.price)) {
      rent.price = rent.pricePerDay
    }

    alert('Total price is' + rent.price)
    price = rent.price
    console.log(rent)
  }

  const handleInputChange = (event) => {
    const { name, value } = event.target
    setRent({ ...rent, [name]: value })
    if (name == 'endDate') RecalculatePrice()
  }

  const saveRent = () => {
    var arr = []
    rent.additionalOptions.forEach((x) => arr.push({ id: x }))

    const rentJson = {
      beginDate: rent.beginDate + 'T' + rent.beginTime + 'Z',
      endDate: rent.endDate + 'T' + rent.endTime + 'Z',
      price: rent.price,
      rentStatusId: 1,
      customerId: rent.customerId,
      carId: parseInt(rent.carId),
      additionalOptions: arr,
    }

    console.log(rentJson)
    console.log(rent)

    axios
      .post(`${baseUrl}/Rents`, rentJson)
      .then((responce) => {
        var data = responce.data
        console.log(data)
        //console.log(responce.)
      })
      .catch((e) => {
        console.log(e)
        alert(e)
        //return false
      })
  }

  const newRent = () => {
    //setTutorial(initialTutorialState)
    //console.log(rent)
    saveRent()
    GoToUserPage()
  }

  function GoToUserPage() {
    history.push({
      pathname: '/user/' + UserData?.id, // userId must be here
      state: { personId: UserData?.id }, // here too
    })
  }

  const handleIdChange = (e) => {
    let tempValue = e.target.value
    if (!rent.additionalOptions.includes(parseInt(tempValue))) {
      rent.additionalOptions.push(parseInt(tempValue))
    } else {
      rent.additionalOptions.pop(parseInt(tempValue))
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
                  min={initialRentState.beginDate}
                  onChange={handleInputChange}
                />
              </Col>
              <Col>
                <input
                  className='dataText text-left'
                  type='time'
                  id='beginTime'
                  name='beginTime'
                  value={rent.beginTime}
                  min={initialRentState.beginTime}
                  onChange={handleInputChange}
                />
              </Col>
            </Row>
            <h5 className='headerText'>Car return date</h5>
            <Row>
              <Col>
                <input
                  className='dataText text-left'
                  type='date'
                  id='endDate'
                  name='endDate'
                  value={rent.endDate}
                  min={initialRentState.endDate}
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
                  min={initialRentState.endTime}
                  onChange={handleInputChange}
                />
              </Col>
            </Row>
            <h5 className='headerText'>Additional options</h5>
            <Container className='CheckBoxStyle'>
              {options?.map((option) => (
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
                    value={car?.averageMark}
                    size={24}
                    isHalf={true}
                    activeColor='#ffd700'
                    edit={false}
                  />
                </Col>
                <Col>
                  <h4>{car?.averageMark}</h4>
                </Col>
              </Row>
              <h5 className='headerText'>
                Total
                {/*rent?.price ?? 'price'*/}
              </h5>
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
}

export default BookingCarPage

/*
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
            */

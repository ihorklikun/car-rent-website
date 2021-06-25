import React, { useState, useEffect, useContext } from 'react'
import './AppUserPageStyle.css'
import { RiUserLine } from 'react-icons/ri'
import { Container, Row, Col, Button } from 'react-bootstrap'
import UserCarsInfoTemplate from './UserCarsInfoTemplate'
import http from '../../http-common'
import { useHistory, useLocation } from 'react-router-dom'

function AppUserPage(props) {
  //var history = null;
  //var active= null;
  const location = useLocation()
  var history = useHistory()
  var personId = location.state.personId
  const [userRentInfo, setUserRentInfo] = useState(null)
  const [userInfo, setUserInfo] = useState(null)

  useEffect(() => {
    // http.get("/user/" + personId).then((responce)=>{
    //     const data = responce.data;
    //     setUserInfo(data);
    // }).catch(e=>{
    //     console.log(e);
    // });
    var personInfo = localStorage.getItem('currentUser')
    var data = JSON.parse(personInfo)
    //console.log(personInfo);
    setUserInfo(data)

    if (data?.roleId == 1) {
      http
        .get('http://localhost:25094/rents/user/' + data.id)
        .then((responce) => {
          const data = responce.data
          setUserRentInfo(data)
        })
        .catch((e) => {
          console.log(e)
        })
      //setUserRentInfo(rent);
    }
  }, [setUserInfo])//

  useEffect(() => {
    //if (userInfo.roleId == 1) {
    //    // http.get("/Rents").then((responce)=>{
    //    //     const data = responce.data;
    //    //     setUserRentInfo(data);
    //    // }).catch(e=>{
    //    //     console.log(e);
    //    // });
    //    setUserRentInfo(rent);
    //}
  })

  const getActiveRents = () => {
    if (userRentInfo != null) {
      return userRentInfo.map((unit) => {
        var dateEnd = new Date(unit.endDate)
        var date = new Date()
        if (dateEnd > date)
          return <UserCarsInfoTemplate data={unit} key={unit.id} />
        else return null
      })
    } else {
      return <Container />
    }
  }
  const getRentsHistory = () => {
    if (userRentInfo != null) {
      return userRentInfo.map((unit) => {
        var dateEnd = new Date(unit.endDate)
        var date = new Date()
        if (dateEnd < date)
          return <UserCarsInfoTemplate data={unit} key={unit.id} />
        else return null
      })
    } else {
      return <Container />
    }
  }
  function getContent() {
    if (userInfo?.roleId == 1) {
      return (
        <Container fluid>
          <h1 className='header'>Rented cars</h1>
          {getActiveRents()}
          <h1 className='header'>Rents history</h1>
          {getRentsHistory()}
        </Container>
      )
    } else if (userInfo?.roleId == 2) {
      return (
        <Container fluid>
          <Button
            variant='secondary'
            id='buttonStyle'
            onClick={() =>
              history.push({
                pathname: '/manager/cars',
              })
            }
          >
            Cars page
          </Button>
          <Button
            variant='secondary'
            id='buttonStyle'
            style={{ marginTop: '0' }}
            onClick={() =>
              history.push({
                pathname: '/manager/rents',
              })
            }
          >
            Rents page
          </Button>
          <Button
            variant='secondary'
            id='buttonStyle'
            style={{ marginTop: '0' }}
            onClick={() =>
              history.push({
                pathname: '/manager/users',
              })
            }
          >
            Users page
          </Button>
        </Container>
      )
    } else if (userInfo?.roleId == 3) {
      return (
        <Container>
          <Button
            variant='secondary'
            id='buttonStyle'
            onClick={() =>
              history.push({
                pathname: '/service',
              })
            }
          >
            Service tasks page
          </Button>
        </Container>
      )
    }
  }
  if (userInfo != null)
    return (
      <Container className='text-center'>
        <h1 className='header'>User info </h1>
        <Container>
          <Row className='pageStyle'>
            <Col md={3}>
              <RiUserLine size='200px' />
            </Col>
            <Col md={9} className='my-auto'>
              <div className=' h-100'>
                <h3 className='textStyle'>
                  Name: {userInfo?.surname ?? '' + ' ' + userInfo?.name ?? ''}
                </h3>
                <h3 className='textStyle'>Email: {userInfo?.email ?? ''}</h3>
                <h3 className='textStyle'>
                  Position: {userInfo?.roleName ?? ''}
                </h3>
              </div>
            </Col>
          </Row>
        </Container>
        {getContent()}
        {/* <h1 className = "header">Rented cars</h1>
            {getActiveRents()}
        <h1 className = "header">Rents history</h1>
            <UserCarsInfoTemplate/> */}
      </Container>
    )
  else
    return (
      <Container className='text-center'>
        <h1>Cant` receive data about user</h1>
      </Container>
    )
}

export default AppUserPage

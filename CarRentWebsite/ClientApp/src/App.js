import React, { Component } from 'react';
import { Layout } from './components/Layout';

import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { 
  BrowserRouter as Router, 
  Switch, 
  Route
} from 'react-router-dom';

import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import NaviBar from './components/Navibar.js'
import Footer from './components/Footer.js'
import Home from './Pages/HomePage/Home';
import About from './Pages/AboutUsPage/About';
import BookingCarPage from './Pages/BookingCarPage/BookingCarPage';
import CarInfo from './Pages/CarInfoPage/CarInfo';
import CarManagerInfo from "./Pages/CarManagerInfo/CarManagerInfo";

function App() {
  return (
    <>
    <Router>
    <NaviBar/>
    <Switch>
      <Route exact path="/" component={Home} />
      <Route exact path='/carInfo' component={CarInfo} />
      <Route path='/carManagerInfo' component={CarManagerInfo} />
      <Route exact path="/about" component={About} />
      <Route exact path='/bookingCarPage' component={BookingCarPage} />
      <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
    </Switch>
    </Router>
    <Footer/>
    </>
  );
}export default App;

import React, { Component, useState } from 'react';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import Home from './Pages/HomePage/Home';
import About from './Pages/AboutUsPage/About';
import BookingCarPage from './Pages/BookingCarPage/BookingCarPage';
import CarInfo from './Pages/CarInfoPage/CarInfo';
import CarManagerInfo from "./Pages/CarManagerInfo/CarManagerInfo";
import { Layout } from './components/Layout'
import CarsListPage from './Pages/CarsListPage/CarsListPage';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import AppUserPage  from './Pages/AppUserPage/AppUserPage';
import Rules from './Pages/RulesPage/Rules';
import { 
  BrowserRouter as Router, 
  Switch, 
  Route
} from 'react-router-dom';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <AuthorizeRoute path='/fetch-data' component={FetchData} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
      </Layout>
    );
  }
}

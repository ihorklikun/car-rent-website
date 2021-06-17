import React, { Component } from 'react';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import Home from './Pages/HomePage/Home';
import About from './Pages/AboutUsPage/About';
import BookingCarPage from './Pages/BookingCarPage/BookingCarPage';
import CarInfo from './Pages/CarInfoPage/CarInfo';
import CarManagerInfo from "./Pages/CarManagerInfo/CarManagerInfo";
import { Layout } from './components/Layout'

import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import AppUserPage  from './Pages/AppUserPage/AppUserPage';
import { 
  BrowserRouter as Router, 
  Switch, 
  Route
} from 'react-router-dom';



export default class App extends Component {

    render() {
        return (
        <Router>
            <Layout>
                
                    <Route exact path="/" component={Home} />
                    <Route exact path='/carInfo' component={CarInfo} />
                    <Route path='/carManagerInfo' component={CarManagerInfo} />
                    <Route exact path="/about" component={About} />
                    <Route exact path='/bookingCarPage' component={BookingCarPage} />
                    <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                    <Route exact path = "/user/:id" component = {AppUserPage}></Route>
                    <Route exact path = "/manager/cars" component = {null}></Route>
                    <Route exact path = "/service" component = {null}></Route>
                    <Route exact path = "/manager/rents" component = {null}></Route>
            </Layout>
        </Router>
            
        );
    }
}



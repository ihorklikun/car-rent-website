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
import { useContext } from 'react';
import UserContext from './UserContext';
import { 
  BrowserRouter as Router, 
  Switch, 
  Route
} from 'react-router-dom';

function App () {
  const [person, setPerson] = useState(null);
  const value = { person, setPerson }; 
        return (
        <UserContext.Provider value = {value}>
            <Router>
            <Layout>
                
                    <Route exact path="/" component={Home} />
                    <Route exact path="/index" component={Home} />
                    <Route exact path="/index.html" component={Home} />
                    <Route exact path='/carInfo/:id' component={CarInfo} />
                    <Route path='/carManagerInfo' component={CarManagerInfo} />
                    <Route exact path="/about" component={About} />
                    <Route exact path='/booking' component={BookingCarPage} />
                    <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                    <Route exact path = "/user/:id" component = {AppUserPage}></Route>
                    <Route exact path = "/manager/cars" component = {CarsListPage}></Route>
                    <Route exact path = "/manager/cars/:id" component = {CarManagerInfo}></Route>
                    <Route exact path = "/service" component = {null}></Route>
                    <Route exact path = "/manager/rents" component = {null}></Route>
            </Layout>
        </Router>
        </UserContext.Provider>
        
            
        );
    }
export default App;



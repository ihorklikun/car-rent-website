import React from 'react'
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes'
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants'
import Home from './Pages/HomePage/Home'
import About from './Pages/AboutUsPage/About'
import BookingCarPage from './Pages/BookingCarPage/BookingCarPage'
import CarInfo from './Pages/CarInfoPage/CarInfo'
import CarManagerInfo from './Pages/CarManagerInfo/CarManagerInfo'
import { Layout } from './components/Layout'
import CarsListPage from './Pages/CarsListPage/CarsListPage'
import CarRequestPage from './Pages/CarRequestPage/CarRequestPage'
import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import AppUserPage from './Pages/AppUserPage/AppUserPage'
import { BrowserRouter as Router, Route } from 'react-router-dom'
import Rules from "./Pages/RulesPage/Rules";
import UserListPage from './Pages/UserListPage/UserListPage';
function App () {
        return (
            <Router>
            <Layout>
                    <Route exact path="/" component={Home} />
                    <Route exact path="/index" component={Home} />
                    <Route exact path="/index.html" component={Home} />
                    <Route exact path='/carInfo/:id' component={CarInfo} />
                    <Route exact path="/rules" component={Rules} />
                    <Route exact path="/about" component={About} />
                    <Route exact path='/booking' component={BookingCarPage} />
                    <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                    <Route exact path = "/user/:id" component = {AppUserPage}></Route>
                    <Route exact path = "/manager/cars" component = {CarsListPage}></Route>
                    <Route exact path = "/manager/cars/:id" component = {CarManagerInfo}></Route>
                    <Route exact path = "/service" component = {null}></Route>
                    <Route exact path = "/manager/rents" component = {CarRequestPage}></Route>
                    <Route exact path = "/manager/users" component = {UserListPage}></Route>
            </Layout>
        </Router>    
        );
    }
export default App;



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
import UserListPage from './Pages/UserListPage/UserListPage'
import CarRequestPage from './Pages/CarRequestPage/CarRequestPage'
import AddNewCar from './Pages/AddNewCarPage/AddNewCar'
import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import AppUserPage from './Pages/AppUserPage/AppUserPage'
import { BrowserRouter as Router, Route } from 'react-router-dom'
import Rules from './Pages/RulesPage/Rules'
function App() {
  //const [person, setPerson] = useState(null);
  //const value = { person, setPerson };
  return (
    <Router>
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/index' component={Home} />
        <Route exact path='/index.html' component={Home} />
        <Route exact path='/carInfo/:id' component={CarInfo} />
        <Route path='/carManagerInfo' component={CarManagerInfo} />
        <Route exact path='/about' component={About} />
        <Route exact path='/rules' component={Rules} />
        {/*<Route exact path='/booking/:id' component={BookingCarPage} />*/}
        <Route
          path='/booking/:id'
          render={(props) => <BookingCarPage props={props} />}
        />

        <Route exact path='/manager/newCar' component={AddNewCar} />
        <Route
          path={ApplicationPaths.ApiAuthorizationPrefix}
          component={ApiAuthorizationRoutes}
        />
        <Route exact path='/user/:id' component={AppUserPage} />
        <Route exact path='/manager/cars' component={CarsListPage} />
        <Route exact path='/manager/cars/:id' component={CarManagerInfo} />
        <Route exact path='/service' component={null} />
        <Route exact path='/manager/rents' component={CarRequestPage} />
        {/* <Route exact path='/manager/CarRequests' component={CarRequestPage} /> */}
        <Route exact path='/manager/users' component={UserListPage}></Route>
      </Layout>
    </Router>
  )
}
export default App

import React from 'react'
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { 
  BrowserRouter as Router, 
  Switch, 
  Route
} from 'react-router-dom';

import NaviBar from './components/Navibar.js'
import Footer from './components/Footer.js'
import Home from './Pages/HomePage/Home';
import About from './Pages/AboutUsPage/About';
import './custom.css'
import BookingCarPage from './BookingCarPage';

function App() {
  return (
    <>
    <Router>
    <NaviBar/>
    <Switch>
      <Route exact path="/" component={Home} />
      <Route exact path="/about" component={About} />
                  <Route exact path='/bookingCarPage' component={BookingCarPage} />
                  <Route path='/counter' component={Counter} />
                  <AuthorizeRoute path='/fetch-data' component={FetchData} />
                  <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />

      {/* <Route exact path="/rules" component={Rules} /> */}
    </Switch>
    </Router>
    <Footer/>
    </>
  );
}export default App;

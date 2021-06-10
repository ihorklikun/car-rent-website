import React from 'react'
import './ManagerPageStyle.css'
import { RiUserLine } from 'react-icons/ri'
function ManagerPage({ name, surname, position }) {
  return (
    <div className='container col-md-8 col-sm-12'>
      <div className='row pageStyle'>
        <div class='col-md-3'>
          <RiUserLine size='300px' />
        </div>
        <div class='col-md-9 textStyle'>
          <div className='h-100'>
            <h3>Name: {name + ' ' + surname}</h3>
            <h3>Position: {position}</h3>
          </div>
        </div>
      </div>
    </div>
  )
}

export default ManagerPage

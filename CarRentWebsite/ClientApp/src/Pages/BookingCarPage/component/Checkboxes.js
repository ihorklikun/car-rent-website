import React, { useState } from 'react'

function CheckboxesComponent() {
  const initialOptions = [
    {
      id: 1,
      name: 'Child Chair',
      price: 50,
    },
    {
      id: 2,
      name: 'Gps',
      price: 25,
    },
  ]

  const [options, setOptions] = useState(initialOptions)

  let toggleOptions = []

  function handleIdChange(e) {
    let tempValue = e.target.value
    if (!toggleOptions.includes(tempValue)) {
      toggleOptions.push(tempValue)
    } else {
      toggleOptions.pop(tempValue)
    }

    console.log(toggleOptions)
  }

  return options.map((option, index) => (
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
  ))
}

export default CheckboxesComponent

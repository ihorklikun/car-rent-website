import React, {createContext, useContext} from 'react';

var personInfo = {
    "Name": "Andrii",
    "Surname": "Harashchak",
    "Email": "abc@abc.abc",
    "Role": {
      "RoleId": "0",
      "Name": "Manager"
    }
  };
const UserContext = createContext({person: null, setPerson: ()=>{}});

export default UserContext;
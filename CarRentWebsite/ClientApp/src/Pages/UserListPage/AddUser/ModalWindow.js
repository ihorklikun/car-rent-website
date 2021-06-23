import React, { useRef, useEffect, useCallback } from 'react'
import { useSpring, animated } from 'react-spring'
import styled from 'styled-components'
import { MdClose } from 'react-icons/md'
import AddUserForm from './Form'
//import { useState } from 'react'

const Background = styled.div`
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.8);
  position: fixed;
  display: flex;
  justify-content: center;
  align-items: center;
`

const ModalWrapper = styled.div`
  width: 400px;
  height: 600px;
  box-shadow: 0 5px 16px rgba(0, 0, 0, 0.2);
  background: #fff;
  color: #000;
  display: grid;
  position: relative;
  z-index: 10;
  border-radius: 10px;
`

const ModalContent = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  line-height: 1.8;
  color: #141414;

  p {
    margin-bottom: 1rem;
  }

  button {
    padding: 10px 24px;
    background: #141414;
    color: #fff;
    border: none;
  }
`

const CloseModalButton = styled(MdClose)`
  cursor: pointer;
  position: absolute;
  top: 20px;
  right: 20px;
  width: 32px;
  height: 32px;
  padding: 0;
  z-index: 10;
`

export const AddUserModalWindow = ({ showModal, setShowModal, addUser }) => {
  const modalRef = useRef()

  const animation = useSpring({
    config: {
      duration: 250,
    },
    opacity: showModal ? 1 : 0,
    transform: showModal ? `translateY(0%)` : `translateY(-100%)`,
  })

  /*
  const [form, setForm] = useState({
    firstName: 'test',
    lastName: 'test',
    position: 'test',
    email: 'test',
    password: 'test',
  })
  */

  const addUserModal = (form) => {
    addUser(form)
  }

  const closeModal = (e) => {
    if (modalRef.current === e.target) {
      setShowModal(false)
    }
    //addUser(form)
  }

  const keyPress = useCallback(
    (e) => {
      if (e.key === 'Escape' && showModal) {
        setShowModal(false)
        console.log('I pressed')
      }
    },
    [setShowModal, showModal]
  )

  useEffect(() => {
    document.addEventListener('keydown', keyPress)
    return () => document.removeEventListener('keydown', keyPress)
  }, [keyPress])

  /*
  const [form, setForm] = useState({
    firstName: '',
    lastName: '',
    position: '',
    email: '',
  })
  

  
  const addUser = (param) => {
    //addUser(param)
    setForm(param)
    //console.log('params were got')
    //console.log(form.firstName)
    //console.log(form.lastName)
    //console.log(form.position)
    //console.log(form.email)
  }
  */

  return (
    <>
      {showModal ? (
        <Background onClick={closeModal} ref={modalRef}>
          <animated.div style={animation}>
            <ModalWrapper showModal={showModal}>
              <ModalContent>
                <AddUserForm addUserModal={addUserModal} />
              </ModalContent>
              <CloseModalButton
                aria-label='Close modal'
                onClick={() => setShowModal((prev) => !prev)}
              />
            </ModalWrapper>
          </animated.div>
        </Background>
      ) : null}
    </>
  )
}

/*
import AddUserForm from './AddUserForm'
import React, { useState } from 'react'
import Button from 'react-bootstrap/Button'
import { Modal } from 'react-bootstrap'

function AddUserModalWindow(props) {
  const [form, setForm] = useState({
    firstName: '',
    lastName: '',
    position: '',
    email: '',
  })

  const addUser = (param) => {
    setForm(param)
    console.log('params were got')
    console.log(form.firstName)
    console.log(form.lastName)
    console.log(form.position)
    console.log(form.email)
  }

  return (
    <Modal size='lg' aria-labelledby='contained-modal-title-vcenter' centered>
      <Modal.Header closeButton>
        <Modal.Title id='contained-modal-title-vcenter'>
          Adding user
        </Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <AddUserForm addUser={addUser} />
      </Modal.Body>
      <Modal.Footer>
        <Button variant='warning' onClick={addUser}>
          Add
        </Button>
      </Modal.Footer>
    </Modal>
  )
}

export default AddUserModalWindow

*/

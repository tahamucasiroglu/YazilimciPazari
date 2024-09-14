import React, { useState } from 'react';
import {Container} from '@mui/material';
import 'bootstrap/dist/css/bootstrap.min.css';
import {ValidateEmail, ValidateName} from '../../Utils/Validate';
import ContactForm from './Components/ContactForm';
import LocationMap from './Components/LocationMap';

function Contact() {
  const [name, setName] = useState('')
  const [email, setEmail] = useState('')
  const [message, setMessage] = useState('')
  const [nameValidator, setNameValidator] = useState(false)
  const [emailValidator, setEmailValidator] = useState(false)
  const [successAlert, setSuccessAlert] = useState('d-none')

  function handleSubmit(event: React.FormEvent<HTMLFormElement>){
    event.preventDefault();

    if(!ValidateName(name)){setNameValidator(true)}else{setNameValidator(false)}
    if(!ValidateEmail(email)){setEmailValidator(true)}else{setEmailValidator(false)}
    if(!ValidateName(name) || !ValidateEmail(email)){return}

    // email atma işlemleri 

    setSuccessAlert('')
    setTimeout(() => {
      setSuccessAlert('d-none')
    }, 3000); 
    
  }

  return (
    <Container maxWidth="sm">
      <ContactForm 
      email={email} 
      emailValidator={emailValidator} 
      handleSubmit={handleSubmit} 
      message={message} 
      name={name}
      nameValidator={nameValidator}
      setEmail={setEmail}
      setMessage={setMessage}
      setName={setName}
      successAlert={successAlert}/>
      
      <LocationMap />

    </Container>
  );
}

export default Contact;



import { useState } from 'react';
import { Link } from 'react-router-dom';
import SubscribeMail from '../Utils/SubscribeMail';
import { Alert } from '@mui/material';

export default function Footer() {
  const [email, setEmail] = useState('')
  const [successAlert, setSuccessAlert] = useState('d-none');
  const [errorAlert, setErrorAlert] = useState('d-none');

  return (
    <footer className="bg-dark text-white mt-5 py-4 text-center">
      <div className="container">
        <p>© 2024 Yazılımcı Pazarı. Tüm hakları saklıdır.</p>
        <div>
          <Link to="/about" className="text-white mx-2">Hakkında</Link>
          <Link to="/contact" className="text-white mx-2">İletişim</Link>
          <Link to="/privacy" className="text-white mx-2">Gizlilik Politikası</Link>
        </div>
        <div className="mt-2">
          <a href="https://facebook.com" target='_blank' className="text-white mx-1">Facebook</a>
          <a href="https://twitter.com" target='_blank' className="text-white mx-1">Twitter</a>
          <a href="https://instagram.com" target='_blank' className="text-white mx-1">Instagram</a>
        </div>
        <Alert variant="filled" severity="success"  className={successAlert}>
          Başarıyla kaydettik
        </Alert>
       
        <Alert variant="filled" severity="error"  className={errorAlert}>
          Geçerli bir mail adresi giriniz.
        </Alert>
        <div className="mt-3">
          <input type="email" placeholder="E-posta adresiniz" className="mr-2" value={email} onChange={e => setEmail(e.target.value)} />
          <button className="btn btn-primary" onClick={()=>SubscribeMail(email, setSuccessAlert, setErrorAlert)}>Abone Ol</button>
        </div>
      </div>
    </footer>
  );
}

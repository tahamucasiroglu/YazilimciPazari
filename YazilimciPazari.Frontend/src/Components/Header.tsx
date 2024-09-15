import Icon from '/Icons/icon.webp'
import { Link } from 'react-router-dom'
import ErrorOutline from '@mui/icons-material/ErrorOutline';
import { IconButton } from '@mui/material';
import InfoPlayer from './InfoPlayer';
import { useState } from 'react';

export default function Header() {
  const [open, setOpen] = useState(false)
  return (
    <header className="bg-dark p-1 ps-5  pe-5" > 
        <div className='row align-items-center'> 
          <div className='col-md-6'> 
          <Link to='/' className='btn btn-link'>
            <img src={Icon} alt='yazilim pazari sitesi icon resmi' style={{ width: '100px', height: 'auto' }} />
          </Link>
          </div>
          <div className='col-md-6 d-flex justify-content-end'> 
            <Link to='/' className='btn btn-link text-decoration-none text-white fs-4'>Anasayfa</Link>
            <Link to='/profile' className='btn btn-link text-decoration-none text-white fs-4'>Profil</Link>
            <Link to='/login' className='btn btn-link text-decoration-none text-white fs-4'>Giriş Yap</Link>
            <Link to='/singup' className='btn btn-link text-decoration-none text-white fs-4'>Kayıt Ol</Link>
            <IconButton onClick={() => setOpen(true)}>
              <ErrorOutline className='text-white fs-2' />
            </IconButton>
            <InfoPlayer open={open} setOpen={setOpen}  />
          </div>
      </div>
    </header>
  )
}

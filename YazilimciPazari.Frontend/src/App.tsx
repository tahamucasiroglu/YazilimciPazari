import { Route, Routes } from 'react-router-dom'
import './App.css'
import Main from './Pages/Main/Main'
import Page404 from './Pages/Page404/Page404'
import Profile from './Pages/Profile/Profile'
import Header from './Components/Header'
import Footer from './Components/Footer'
import About from './Pages/About/About'
import Contact from './Pages/Contact/Contact'
import Privacy from './Pages/Privacy/Privacy'
import Test from './Pages/Test/Test'
import SingUp from './Pages/SingUp/SingUp'
import Login from './Pages/Login/Login'

function App() {
  return (
    <div id='root' className='d-flex flex-column mb-2'>
      <div className='p-0'>
        <Header />
        <Routes>
          <Route path='/' element={<Main/>}/>
          <Route path='/profile' element={<Profile/>}/>
          <Route path='/about' element={<About/>}/>
          <Route path='/contact' element={<Contact/>}/>
          <Route path='/privacy' element={<Privacy/>}/>
          <Route path='/test' element={<Test/>}/>
          <Route path='/singup' element={<SingUp/>}/>
          <Route path='/login' element={<Login/>}/>
          <Route path='*' element={<Page404/>}/>
        </Routes> 
      </div>
      <div className='p-0'>
        <Footer />
      </div>
    </div>
  )
}

export default App
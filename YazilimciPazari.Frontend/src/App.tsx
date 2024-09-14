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

function App() {
  return (
    <div id='root'>
      <div className='content-wrap'>
       <Header />
      <Routes>
      <Route path='/' element={<Main/>}/>
      <Route path='/profile' element={<Profile/>}/>
      <Route path='/about' element={<About/>}/>
      <Route path='/contact' element={<Contact/>}/>
      <Route path='/privacy' element={<Privacy/>}/>
      <Route path='/test' element={<Test/>}/>
      <Route path='*' element={<Page404/>}/>
      </Routes> 
      </div>
      <Footer />
    </div>
  )
}

export default App
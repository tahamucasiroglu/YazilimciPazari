import PersonCard from './Components/PersonCard'
import CompanyCard from './Components/CompanyCard'
import MainBackground from '/Backgrounds/MainBackground.png'
import Ben from '/DefaultPP/ben.png'
import DefaultMan from '/DefaultPP/default_man.webp'
import DefaultWoman from '/DefaultPP/default_women.webp'
import DefaultCompany from '/DefaultPP/default_company.webp'
import './style.css'

export default function Main() {
  return (
    <div className=''>
      <div className='d-flex justify-content-center'>
        <div className='card1'><PersonCard id={1} age={25} description={"Fake / Sahte İnsan 1".repeat(10) } image={DefaultMan} name={"Ali"} surname={"Şehzade"} /></div>
        <div className='card2'><PersonCard id={2} age={25} description={"Fake / Sahte İnsan 2".repeat(10)} image={DefaultMan} name={"Mehmet"} surname={"Özpalamutçuoğlu"} /></div>
        <div className='card3'><PersonCard id={3} age={25} description={"Fake / Sahte İnsan 3".repeat(10)} image={DefaultMan} name={"İbrahim"} surname={"Sertbakırcı"} /></div>
        <div className='card4'><PersonCard id={4} age={25} description={"Benim. Ahmet Taha Mücasiroğlu. Trabzon Ktü mezunu "} image={Ben} name={"Ahmet Taha"} surname={"Mücasiroğlu"} /></div>
        <div className='card5'><PersonCard id={5} age={25} description={"Fake / Sahte İnsan 4".repeat(10)} image={DefaultWoman} name={"Ayşe"} surname={"Kadıefendiler"} /></div>
        <div className='card6'><PersonCard id={6} age={25} description={"Fake / Sahte İnsan 5".repeat(10)} image={DefaultWoman} name={"Fatma"} surname={"Hükümdaroğlu"} /></div>
        <div className='card7'><PersonCard id={7} age={25} description={"Fake / Sahte İnsan 6".repeat(10)} image={DefaultWoman} name={"Hayriye"} surname={"Gılgamışlılar"} /></div>
      </div>
      <div className=''>
        <div className=''><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 1".repeat(50) } image={DefaultCompany} name={"Ali"} /></div>
        <div className=''><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 2".repeat(50) } image={DefaultCompany} name={"Ali"} /></div>
        <div className=''><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 3".repeat(50) } image={DefaultCompany} name={"Ali"} /></div>
        <div className=''><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 4".repeat(50) } image={DefaultCompany} name={"Ali"} /></div>
        <div className=''><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 5".repeat(50) } image={DefaultCompany} name={"Ali"} /></div>
      </div>
      <div className='position-absolute z-n1 top-0'>
        <img src={MainBackground} className='w-100 h-100' alt='yazılım pazara yazilim pazari sitesi background resmi arkaplan resmi'/>
        <img src={MainBackground} className='w-100 h-100' alt='yazılım pazara yazilim pazari sitesi background resmi arkaplan resmi'/>
        <img src={MainBackground} className='w-100 h-100' alt='yazılım pazara yazilim pazari sitesi background resmi arkaplan resmi'/>
      </div>
      
    </div>
  )
}

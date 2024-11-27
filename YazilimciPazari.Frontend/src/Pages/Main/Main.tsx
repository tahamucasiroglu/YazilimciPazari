import PersonCard from './Components/PersonCard'
import CompanyCard from './Components/CompanyCard'
import Ben from '/DefaultPP/ben.png'
import DefaultMan from '/DefaultPP/default_man.webp'
import DefaultWoman from '/DefaultPP/default_women.webp'
import DefaultCompany from '/DefaultPP/default_company.webp'
import MainBackground from '/Backgrounds/MainBackground.png'
import './style.css'

export default function Main() {
  return (
    <div className=''>
      <div className='d-flex justify-content-center'>
        <div className='personcard1'><PersonCard id={1} age={25} description={"Fake / Sahte İnsan 1 ".repeat(10) } image={DefaultMan} name={"Ali"} surname={"Şehzade"} /></div>
        <div className='personcard2'><PersonCard id={2} age={25} description={"Fake / Sahte İnsan 2 ".repeat(10)} image={DefaultMan} name={"Mehmet"} surname={"Özpalamutçuoğlu"} /></div>
        <div className='personcard3'><PersonCard id={3} age={25} description={"Fake / Sahte İnsan 3 ".repeat(10)} image={DefaultMan} name={"İbrahim"} surname={"Sertbakırcı"} /></div>
        <div className='personcard4'><PersonCard id={4} age={25} description={"Benim. Ahmet Taha Mücasiroğlu. Trabzon Ktü mezunu "} image={Ben} name={"Ahmet Taha"} surname={"Mücasiroğlu"} /></div>
        <div className='personcard5'><PersonCard id={5} age={25} description={"Fake / Sahte İnsan 4 ".repeat(10)} image={DefaultWoman} name={"Ayşe"} surname={"Kadıefendiler"} /></div>
        <div className='personcard6'><PersonCard id={6} age={25} description={"Fake / Sahte İnsan 5 ".repeat(10)} image={DefaultWoman} name={"Fatma"} surname={"Hükümdaroğlu"} /></div>
        <div className='personcard7'><PersonCard id={7} age={25} description={"Fake / Sahte İnsan 6 ".repeat(10)} image={DefaultWoman} name={"Hayriye"} surname={"Gılgamışlılar"} /></div>
      </div>
      <div className=''>
        <div className='companycard1'><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 1 ".repeat(50) } image={DefaultCompany} name={"Şirket 1"} /></div>
        <div className='companycard2'><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 2 ".repeat(50) } image={DefaultCompany} name={"Şirket 2"} /></div>
        <div className='companycard3'><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 3 ".repeat(50) } image={DefaultCompany} name={"Şirket 3"} /></div>
        <div className='companycard4'><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 4 ".repeat(50) } image={DefaultCompany} name={"Şirket 4"} /></div>
        <div className='companycard5'><CompanyCard id={1} foundationDate={new Date(2005,5,5,5,5,5,5)} description={"Fake / Sahte Şirket 5 ".repeat(50) } image={DefaultCompany} name={"Şirket 5"} /></div>
      </div>
    </div>
  )
}

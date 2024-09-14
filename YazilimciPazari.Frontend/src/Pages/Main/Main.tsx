import PersonCard from './Components/PersonCard'
import MainBackground from '/Backgrounds/MainBackground.png'
import Ben from '/DefaultPP/ben.png'
import DefaultMan from '/DefaultPP/default_man.webp'
import DefaultWoman from '/DefaultPP/default_women.webp'

export default function Main() {
  return (
    <div className='position-relative'>
      <img src={MainBackground} className='w-100 ps-2 pe-2 img-fluid rounded d-block' alt='yazılım pazara yazilim pazari sitesi backgroun resmi arkaplan resmi'/>
      <div className='d-flex justify-content-center mainCard'>
      <PersonCard id={1} age={25} description={"Fake / Sahte İnsan 1"} image={DefaultMan} name={"Ali"} surname={"Veli"} />
      <PersonCard id={2} age={25} description={"Fake / Sahte İnsan 2"} image={DefaultMan} name={"Mehmet"} surname={"Özpalamutçuoğlu"} />
      <PersonCard id={3} age={25} description={"Fake / Sahte İnsan 3"} image={DefaultMan} name={"İbrahim"} surname={"Sertbakırcı"} />
      <PersonCard id={4} age={25} description={"insan"} image={Ben} name={"Ahmet Taha"} surname={"Mücasiroğlu"} />
      <PersonCard id={5} age={25} description={"Fake / Sahte İnsan 4"} image={DefaultWoman} name={"Ayşe"} surname={"Tripoğlu"} />
      <PersonCard id={6} age={25} description={"Fake / Sahte İnsan 5"} image={DefaultWoman} name={"Fatma"} surname={"Çeyizci"} />
      <PersonCard id={7} age={25} description={"Fake / Sahte İnsan 6"} image={DefaultWoman} name={"Hayriye"} surname={"Gılgamışlılar"} />
      </div>
      
    </div>
  )
}

import { Link } from "react-router-dom";
import AboutText from "./Components/AboutText";

export default function About() {
  return (
    <div>
      <div className="text-center">
        <Link to='https://github.com/tahamucasiroglu/FrontendSelfcamp' target="_blank">Buradaki reponun pekişmesi için yapılan basit bir site</Link>
      </div>
      
      <br/>
      <hr/>
      <br/>

      <AboutText/>
    </div>
  )
}

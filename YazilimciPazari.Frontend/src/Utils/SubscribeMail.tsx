import {ValidateEmail} from "./Validate";
  
export default async function SubscribeMail(email:string, setSuccessAlert:React.Dispatch<React.SetStateAction<string>>, setErrorAlert:React.Dispatch<React.SetStateAction<string>>) {
    if (ValidateEmail(email)) {
        setSuccessAlert('')
        // apiye mail iletimi işlemleri
        setTimeout(() => {
            setSuccessAlert('d-none')
        }, 3000);    
    }
    else{
        setErrorAlert('')
        setTimeout(() => {
          setErrorAlert('d-none')  
        }, 3000);
    }
}
import { Typography } from '@mui/material'
import PrivacyPolicy from './Components/PrivacyPolicy'

export default function Privacy() {
  return (
    <>
    <Typography component="div" className='text-danger' variant='h2'>ChatGPT Yazdı. Geçersizdir.</Typography>
    <PrivacyPolicy/>
    </>
  )
}

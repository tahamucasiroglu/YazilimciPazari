import { Typography, Button, Container, Box } from '@mui/material';
import { Link } from 'react-router-dom';
import panicGif from '/Icons/panic.gif'

export default function Page404() {
  return (
    <Container component="main" maxWidth="sm" sx={{ textAlign: 'center', pt: 8 }}>
      <Box sx={{ my: 4 }}>
        <img src={panicGif}/>
        <Typography variant="h2" component="h1" gutterBottom>
          404
        </Typography>
        <Typography variant="h5" gutterBottom>
          Oops! Sayfa bulunamadı.
        </Typography>
        <Typography variant="body1" color="textSecondary">
          Aradığınız sayfayı bulamadık. Yanlış bir bağlantıyı takip etmiş olabilirsiniz veya sayfa kaldırılmış olabilir.
        </Typography>
        <Button
          variant="contained"
          color="primary"
          sx={{ mt: 3 }}
          component={Link}
          to="/"
        >
          Ana Sayfaya Dön
        </Button>
      </Box>
    </Container>
  )
}

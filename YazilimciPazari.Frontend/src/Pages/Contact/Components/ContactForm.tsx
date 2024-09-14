import { Alert, Button, Grid, TextField, Typography } from "@mui/material";

type inputType = {
  handleSubmit: (event: React.FormEvent<HTMLFormElement>) => void, 
  name: string, 
  setName: React.Dispatch<React.SetStateAction<string>>, 
  nameValidator: boolean, 
  email: string, 
  setEmail: React.Dispatch<React.SetStateAction<string>>, 
  emailValidator: boolean, 
  message: string, 
  setMessage: React.Dispatch<React.SetStateAction<string>>, 
  successAlert: string
}

export default function ContactForm(props:inputType) {
    return (
      <>
        <Typography variant="h4" component="h1" gutterBottom>
          İletişim Formu
        </Typography>
        <form onSubmit={props.handleSubmit} method='POST'>
          <Grid container spacing={2}>
            <Grid item xs={12}>
              <TextField
                fullWidth
                label="Adınız"
                name="name"
                value={props.name}
                onChange={e => props.setName(e.target.value)}
                variant="outlined"
                error={props.nameValidator} />
            </Grid>
            <Grid item xs={12}>
              <TextField
                fullWidth
                label="E-posta Adresiniz"
                name="email"
                value={props.email}
                onChange={e => props.setEmail(e.target.value)}
                type="email"
                variant="outlined"
                error={props.emailValidator} />
            </Grid>
            <Grid item xs={12}>
              <TextField
                fullWidth
                label="Mesajınız"
                name="message"
                value={props.message}
                onChange={e => props.setMessage(e.target.value)}
                multiline
                rows={4}
                variant="outlined" />
            </Grid>
            <Grid item xs={12}>
              <Button type="submit" fullWidth variant="contained" color="primary">
                Gönder
              </Button>
              <Alert variant="filled" severity="success" className={props.successAlert}>
                Mesajınız bize ulaştı. En kısa sürede cevap vereceğiz.
              </Alert>
            </Grid>
          </Grid>
        </form>
      </>
    
    );
  }
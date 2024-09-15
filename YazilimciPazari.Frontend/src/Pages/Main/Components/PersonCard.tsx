import { Card, CardContent, CardMedia, Typography } from '@mui/material';
import { Link } from 'react-router-dom';
type personCardType = {
    id:number,
    name:string,
    surname:string,
    age:number,
    image:string,
    description:string,
}

export default function PersonCard(profile:personCardType) {
    const linkUrl = `profile/${profile.id}`
    return (
        <Link to={linkUrl} className='text-decoration-none'>
            <Card sx={{ maxWidth: 235, m: 1 }}>
                <CardMedia
                component="img"
                height="140"
                image={profile.image}
                alt= {profile.name + "\n" + profile.surname}
                sx={{ width: "50%", height: "50%", borderRadius: '50%', display: "block", ml: "auto", mr:"auto"}}
                />
                <CardContent>
                <Typography gutterBottom variant="h5" component="div" sx={{ textAlign: 'center' }}>
                    {profile.name + " " + profile.surname}
                </Typography>
                <Typography variant="body2" color="text.secondary" sx={{ textAlign: 'center' }}>
                    Age: {profile.age}
                </Typography>
                <Typography variant="body1" sx={{ textAlign: 'center', mt: 1 }}>
                    {profile.description}
                </Typography>
                </CardContent>
            </Card>
        </Link>
      );
}






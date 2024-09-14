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
            <Card sx={{ maxWidth: 345, m: 2 }}>
                <CardMedia
                component="img"
                height="140"
                image={profile.image}
                alt= {profile.name + "\n" + profile.surname}
                sx={{ width: 150, height: 150, borderRadius: '50%', ml: 5, mr:5, mt: 2 }}
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






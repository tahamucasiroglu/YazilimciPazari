import { Card, CardContent, CardMedia, Typography } from '@mui/material';
import { Link } from 'react-router-dom';
type companyCardType = {
    id:number,
    name:string,
    foundationDate:Date,
    image:string,
    description:string,
}



export default function CompanyCard(profile:companyCardType) {
    const linkUrl = `profile/${profile.id}`
    return (
        <div className=''>
            <Link to={linkUrl} className='text-decoration-none'>
                <Card  className='d-flex p-2 m-3 border border-ligth rounded-pill'>
                    <CardMedia
                    className='companyImage'
                    component="img"
                    height="140"
                    image={profile.image}
                    alt= {profile.name}
                    sx={{width: "50%", height: "50%", maxWidth: 235, borderRadius: '50%', display: "block", m:"auto"}}
                    />
                    <CardContent>
                    <Typography gutterBottom variant="h5" component="div" sx={{ textAlign: 'center' }}>
                        {profile.name}
                    </Typography>
                    <Typography variant="body2" color="text.secondary" sx={{ textAlign: 'center' }}>
                        Foundation Date: {profile.foundationDate.toTimeString()}
                    </Typography>
                    <Typography variant="body1" sx={{ textAlign: 'center', mt: 1 }}>
                        {profile.description}
                    </Typography>
                    </CardContent>
                </Card>
            </Link>
        </div>
      );
}

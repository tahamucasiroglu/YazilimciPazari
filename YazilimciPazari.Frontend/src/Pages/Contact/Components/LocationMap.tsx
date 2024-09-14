export default function LocationMap() {
    const url = "https://maps.google.com/maps?q=36.625187432260546,29.13222510090196&t=&z=14&ie=UTF8&iwloc=&output=embed"
  return (
    <iframe height={400} className="w-100 mt-4" id="gmap_canvas" src={url}/>
  )
}
